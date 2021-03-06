﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Model;
using System.Data;
using Registration.DatabaseFactory;
using Registration.DataInterface.Sql;

namespace SearchFolderService
{
    public class SentFolderService : FolderService
    {
        const string SpGetLettersFromSentFolder = "sp_GetLettersFromSentFolder";
        const string SpGetCountLettersInSentFolder = "sp_GetCountLettersInSentFolder";


        const string IdFolderColumn = "@idFolder";

        const string IdLetter = "idLetter";
        const string NameLetter = "nameLetter";
        const string IdSender = "idSender";
        const string Text = "text";
        const string Date = "date";
        const string NameWorker = "nameWorker";
        const string CountLetters = "countLetters";
        private static Database _database = null;
        
        override public int GetCountLettersInFolder(Guid folderId)
        {
            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand(SpGetCountLettersInSentFolder, connection))
                {
                    Database.AddParameterWithValue(IdFolderColumn, folderId, command);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(reader.GetOrdinal(CountLetters));
                        }
                        throw new Exception($"Folder {folderId} isn't exist!");
                    }
                }
            }
        }

        override public IEnumerable<LetterView> GetLettersInFolder(Guid folderId)
        {
            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand(SpGetLettersFromSentFolder, connection))
                {
                    Database.AddParameterWithValue(IdFolderColumn, folderId, command);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        var allLettersViewInSentFolder = new List<LetterView>();
                        while (reader.Read())
                        {
                            var letterView = new LetterView()
                            {
                                Id = reader.GetGuid(reader.GetOrdinal(IdLetter)),
                                Name = reader.GetString(reader.GetOrdinal(NameLetter)),
                                IdSender = reader.GetGuid(reader.GetOrdinal(IdSender)),
                                Text = reader.GetString(reader.GetOrdinal(Text)),
                                Date = reader.GetDateTime(reader.GetOrdinal(Date)),
                                SenderName = reader.GetString(reader.GetOrdinal(NameWorker)),
                                IdFolder = folderId,
                                IsRead = true
                            };
                            allLettersViewInSentFolder.Add(letterView);
                        }
                        if (allLettersViewInSentFolder.Count() == 0)
                        {
                            throw new Exception($"Folder {folderId} is empty");
                        }
                        return allLettersViewInSentFolder;
                    }
                }
            }
        }
    }
}
