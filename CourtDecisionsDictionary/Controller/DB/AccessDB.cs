using System;
using System.Collections.Generic;

namespace CourtDecisionsDictionary.Controller.DB
{
    public enum UserRrole { Client, Admin, ContentManager, NotAuthorized, Failed }

    public class AccessDB
    {
        public static string LastErrorText = "";

        public static UserRrole Login(string login, string password)
        {
            try
            {
                // Данные пользователя получены из БД
                foreach (var item in new DB_CDRSDataSetTableAdapters.usersTableAdapter().TryToLogin
                    (login, Security.Secure.Hash(password)))
                    return (UserRrole)item.access_id;

                // Данные пользователя не получены из БД
                return UserRrole.NotAuthorized;

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;
                return UserRrole.Failed;
            }
        }


        public static Model.Region GetRegionData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.regionTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.regionTableAdapter();
                DB_CDRSDataSet.regionDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.Region entity = new Model.Region(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о регионе с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.LawArticle GetLawArticleData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.law_articleTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.law_articleTableAdapter();
                DB_CDRSDataSet.law_articleDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.LawArticle entity = new Model.LawArticle(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о статье спора с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }
        
        public static Model.Post GetPostData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.postTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.postTableAdapter();
                DB_CDRSDataSet.postDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.Post entity = new Model.Post(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о должности с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.DecisionType GetDecisionTypeData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.decision_typeTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.decision_typeTableAdapter();
                DB_CDRSDataSet.decision_typeDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.DecisionType entity = new Model.DecisionType(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о виде дела с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.DocumentType GetDocumentTypeData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.document_typeTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.document_typeTableAdapter();
                DB_CDRSDataSet.document_typeDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.DocumentType entity = new Model.DocumentType(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о виде решения с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.Court GetCourtData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.courtTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.courtTableAdapter();
                DB_CDRSDataSet.courtDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.Court entity = new Model.Court(ID);

                    entity.Name = Convert.ToString(_t_data[0].ItemArray[1]);
                    entity.Address = Convert.ToString(_t_data[0].ItemArray[2]);
                    entity.President = Convert.ToString(_t_data[0].ItemArray[3]);
                    entity.Site = Convert.ToString(_t_data[0].ItemArray[4]);
                    entity.Phone = Convert.ToString(_t_data[0].ItemArray[5]);
                    entity.Location = Convert.ToString(_t_data[0].ItemArray[6]);
                    entity.RegionID = Convert.ToInt32(_t_data[0].ItemArray[7]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о судебном участке с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.Judge GetJudgeData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.judgeTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.judgeTableAdapter();
                DB_CDRSDataSet.judgeDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.Judge entity = new Model.Judge(ID);

                    entity.FirstName = Convert.ToString(_t_data[0].ItemArray[1]);
                    entity.SecondName = Convert.ToString(_t_data[0].ItemArray[2]);
                    entity.FurName = Convert.ToString(_t_data[0].ItemArray[3]);
                    entity.PostID = Convert.ToInt32(_t_data[0].ItemArray[4]);
                    entity.CourtID = Convert.ToInt32(_t_data[0].ItemArray[5]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о судье с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static Model.Document GetDocumentData(int ID)
        {
            if (ID == 0)
            {
                LastErrorText = "ID не может быть равным нулю!";

                return null;
            }

            try
            {
                DB_CDRSDataSetTableAdapters.documentTableAdapter _t_adapter =
                    new DB_CDRSDataSetTableAdapters.documentTableAdapter();
                DB_CDRSDataSet.documentDataTable _t_data = _t_adapter.GetDataByID(ID);

                if (_t_data.Rows.Count > 0)
                {
                    Model.Document entity = new Model.Document(ID);

                    entity.DecisionNumber = Convert.ToString(_t_data[0].ItemArray[1]);
                    entity.Date = Convert.ToDateTime(_t_data[0].ItemArray[2]);
                    entity.ContentFileName = Convert.ToString(_t_data[0].ItemArray[3]);
                    entity.DecisionTypeID = Convert.ToInt32(_t_data[0].ItemArray[4]);
                    entity.DocumentTypeID = Convert.ToInt32(_t_data[0].ItemArray[5]);
                    entity.CourtID = Convert.ToInt32(_t_data[0].ItemArray[6]);
                    entity.JudgeID = Convert.ToInt32(_t_data[0].ItemArray[7]);
                    entity.LawArticleID = Convert.ToInt32(_t_data[0].ItemArray[8]);

                    return entity;
                }
                else
                {
                    LastErrorText = $"Не найдена запись о документе с ID = {ID}!";

                    return null;
                }

            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return null;
            }
        }

        public static bool SaveNewDocument(Model.Document document)
        {
            try
            {
                new DB_CDRSDataSetTableAdapters.documentTableAdapter().Insert(
                        document.DecisionNumber,
                        document.Date,
                        document.ContentFileName,
                        document.DecisionTypeID,
                        document.DocumentTypeID,
                        document.CourtID,
                        document.JudgeID,
                        document.LawArticleID
                    );

                return true;
            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return false;
            }
        }

        public static bool SaveEditedDocument(Model.Document document)
        {
            try
            {
                new DB_CDRSDataSetTableAdapters.documentTableAdapter().UpdateQuery(
                        document.DecisionNumber,
                        document.Date,
                        document.ContentFileName,
                        document.DecisionTypeID,
                        document.DocumentTypeID,
                        document.CourtID,
                        document.JudgeID,
                        document.LawArticleID,
                        document.ID
                    );

                return true;
            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return false;
            }
        }

        public static bool DeleteDocument(int ID)
        {
            try
            {
                new DB_CDRSDataSetTableAdapters.documentTableAdapter().DeleteQuery(ID);

                return true;
            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return false;
            }
        }

        public static List<Model.Document> GetAllDocuments()
        {
            List<Model.Document> docs = new List<Model.Document>();

            try
            {
                foreach (var item in new DB_CDRSDataSetTableAdapters
                    .documentTableAdapter().GetData())
                {
                    docs.Add(GetDocumentData(item.id));
                }

                return docs;
            }
            catch (Exception ex)
            {
                LastErrorText = ex.Message;

                return docs;
            }
        }
    }
}