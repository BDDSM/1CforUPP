
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ���������������������������������:����������������
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
		public string/*9*/ ���;
		public string/*150*/ ������������;
		public V82.������������/*������*/.������������������������������������� ���;
		public V82.������������/*������*/.������������ ������;
		///<summary>
		///��������������� ���� ��� ���������� ������ �� �����������
		///</summary>
		public V82.�����������������.����������� �����������;
		public object �����������;
		public object ����������;
		public string/*(0)*/ ����������;
		public DateTime �������������;//���� ���������
		public DateTime ������������;//���� ��������
		public string/*(36)*/ �������������;
		public string/*(36)*/ ����������������������;//������������� ���������
		public bool ��������������;
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
						Insert Into _Reference189(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3163RRef
						,_Fld3164RRef
						,_Fld3165RRef
						,_Fld3166RRef
						,_Fld3167RRef
						,_Fld3168
						,_Fld3169
						,_Fld3170
						,_Fld3171
						,_Fld3172
						,_Fld3173)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@���
						,@������
						,@�����������
						,@�����������
						,@����������
						,@����������
						,@�������������
						,@������������
						,@�������������
						,@����������������������
						,@��������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference189
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3163RRef	= @���
						,_Fld3164RRef	= @������
						,_Fld3165RRef	= @�����������
						,_Fld3166RRef	= @�����������
						,_Fld3167RRef	= @����������
						,_Fld3168	= @����������
						,_Fld3169	= @�������������
						,_Fld3170	= @������������
						,_Fld3171	= @�������������
						,_Fld3172	= @����������������������
						,_Fld3173	= @��������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("���", ���.����());
					�������.Parameters.AddWithValue("������", ������.����());
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("����������", ����������.������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("��������������", ��������������);
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
					�������.CommandText = @"Delete _Reference189
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� <> ������������*/)
			{
				/*�����������.�������������������(����������, �����);*/
			}
			/*#���������;*/
		}

		public void �������������������(/*������������������*/)
		{
			if(true/*����������� <> ������������*/)
			{
				/*�����������.��������������������������(����������, ������������������);*/
			}
			/*#���������;*/
		}
	}
}
