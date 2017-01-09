using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Arch.Data;
using Arch.Data.DbEngine;
using DLPT.Entity.DataModel;
using DLPT.Interface.IDao;

namespace DLPT.Dao
{
    /// <summary>
    ///
    /// </summary>
    public partial class AgentGenDao : IAgentGenDao
    {
        readonly BaseDao baseDao = BaseDaoFactory.CreateBaseDao("dao_test");
        
        //�ر�ע�⣬����ǿɿ����ͣ����������·�ʽʹ�ã�
        // var data = reader["field"];
        // entity.stringData = data == null ? data : data.ToString();
        //����Ҫ�ֹ�ӳ�䣬�뷴ע�����´��룬��ע��ת������
        /*
        /// <summary>
        /// �ֹ�ӳ�䣬����ʹ��1.2.0.5�汾���ϵ�VisitDataReader
        /// </summary>
        /// <returns>���</returns>
        public AgentGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<AgentGen>(sql, (reader) =>
                {
                    AgentGen entity = new AgentGen();
					if(reader.Read())
					{
                        entity.Id = reader["Id"];
                        entity.Name = reader["Name"];
                    }
                    return entity;
                });

                //AgentGen entity = new AgentGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.Id = reader["Id"];
                        //entity.Name = reader["Name"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������OrmByHandʱ����", ex);
            }
        }
        */
        /// <summary>
        ///  ����AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>����������,����ж�������򷵻ص�һ������</returns>
		public int InsertAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Insert<AgentGen>(agentGen);
			    int iReturn = Convert.ToInt32(result);
                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenʱ������Insertʱ����", ex);
            }
        }
        /// <summary>
        /// �޸�AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int UpdateAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Update<AgentGen>(agentGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenʱ������Updateʱ����", ex);
            }
        }
        /// <summary>
        /// ɾ��AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>״̬����</returns>
        public int DeleteAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Delete<AgentGen>(agentGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenʱ������Deleteʱ����", ex);
            }
        }
        /// <summary>
        /// ����������ȡAgentGen��Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AgentGen��Ϣ</returns>
        public AgentGen FindByPk(int id )
        {
            try
            {
                return baseDao.GetByKey<AgentGen>(id);
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������FindByPkʱ����", ex);
            }
        }
        /// <summary>
        /// ��ȡ����AgentGen��Ϣ
        /// </summary>
        /// <returns>AgentGen�б�</returns>
        public IList<AgentGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<AgentGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������GetAllʱ����", ex);
            }
        }
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        public long Count()
        {
            try
            {
                String sql = "SELECT count(1) from agent    ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������Countʱ����", ex);
            }
        }
        /// <summary>
        ///  ����AgentGen������ҳ
        /// </summary>
        /// <param name="obj">AgentGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        public IList<AgentGen> GetListByPage(AgentGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select Id, Name from agent ");
                sbSql.Append(" order by Id desc ");
                sbSql.Append(string.Format("limit {0}, {1} ", (pageNo - 1) * pagesize, pagesize));
                IList<AgentGen> list = baseDao.SelectList<AgentGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������GetListByPageʱ����", ex);
            }
        }

		/// <summary>
        ///  ��������AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ������б�</param>
        /// <returns>״̬����</returns>
        public bool BulkInsertAgentGen(IList<AgentGen> agentGenList)
		{
            try
            {
                return baseDao.BulkInsert<AgentGen>(agentGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("����AgentGenDaoʱ������BulkInsertʱ����", ex);
            }
        }

        
    }
}