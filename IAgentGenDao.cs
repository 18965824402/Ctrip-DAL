using System;
using System.Collections.Generic;
using DLPT.Entity.DataModel;

namespace DLPT.Interface.IDao
{
        public partial interface IAgentGenDao
        {

        /// <summary>
        ///  ����AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>����������,����ж�������򷵻ص�һ������</returns>
		int InsertAgentGen(AgentGen agentGen);
        /// <summary>
        /// �޸�AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>״̬����</returns>
        int UpdateAgentGen(AgentGen agentGen);
        /// <summary>
        /// ɾ��AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ�����</param>
        /// <returns>״̬����</returns>
        int DeleteAgentGen(AgentGen agentGen);
        /// <summary>
        /// ����������ȡAgentGen��Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AgentGen��Ϣ</returns>
        AgentGen FindByPk(int id);
        /// <summary>
        /// ��ȡ����AgentGen��Ϣ
        /// </summary>
        /// <returns>AgentGen�б�</returns>
        IList<AgentGen> GetAll();
        /// <summary>
        /// ȡ���ܼ�¼��
        /// </summary>
        /// <returns>��¼��</returns>
        long Count();
		/// <summary>
        ///  ��������AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGenʵ������б�</param>
        /// <returns>״̬����</returns>
        bool BulkInsertAgentGen(IList<AgentGen> agentGenList);
        /// <summary>
        ///  ����AgentGen������ҳ
        /// </summary>
        /// <param name="obj">AgentGenʵ������������</param>
        /// <param name="pagesize">ÿҳ��¼��</param>
        /// <param name="pageNo">ҳ��</param>
        /// <returns>�������</returns>
        IList<AgentGen> GetListByPage(AgentGen obj, int pagesize, int pageNo);


        }
}