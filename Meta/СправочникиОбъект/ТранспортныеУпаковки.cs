
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ��������������������:����������������
	{
		public bool _��������;
		public bool ��������()
		{
			return _��������;
		}
		public Guid ������;
		public long ������;
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		public bool ���������������;
		public bool ����������������;
		public Guid ��������;
		public bool ���������;
		public Guid ��������;
		public decimal/*1*/ ���;
		public string/*150*/ ������������;
		public decimal/*(10.3)*/ �����������;
		public void ��������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					if(_��������)
					{
						�������.CommandText = @"
						Insert Into _Reference274(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3999)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�����������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference274
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3999	= @�����������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.ExecuteNonQuery();
				}
			}
		}
		public void �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Delete _Reference274
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		// ���������� ������� ������������ .
		//

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� = 0*/)
			{
				/*//����������������.����������������("��� ������������ ��������: " + ������������ + " �� ����� �����������! �� ����� ���������� ������ 1.");
*/
				/*����������� = 1;*/
			}
		}
	}
}
