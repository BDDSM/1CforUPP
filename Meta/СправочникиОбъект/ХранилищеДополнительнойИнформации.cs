
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	///<summary>
	///��������� �������������� ����������
	///</summary>
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
		public string/*100*/ ������������;
		///<summary>
		///��� ������
		///</summary>
		public V82.������������/*������*/.������������������������������������ ���������;//��� ������
		///<summary>
		///��� �����
		///</summary>
		public string/*(0)*/ ��������;//��� �����
		///<summary>
		///������
		///</summary>
		public object ������;
		///<summary>
		///���������
		///</summary>
		public ����������������� ���������;
		public ����������������� ����������;//����� �����
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
						Insert Into _Reference288(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld4215RRef
						,_Fld4216
						,_Fld4217RRef
						,_Fld4218
						,_Fld4219)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@������������
						,@���������
						,@��������
						,@������
						,@���������
						,@����������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference288
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Description	= @������������
						,_Fld4215RRef	= @���������
						,_Fld4216	= @��������
						,_Fld4217RRef	= @������
						,_Fld4218	= @���������
						,_Fld4219	= @����������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("���������", ���������.����());
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("������", ������.������);
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
					�������.CommandText = @"Delete _Reference288
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
