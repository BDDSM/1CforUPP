
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
	///(���)
	///</summary>
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
		public string/*9*/ ���;
		public string/*100*/ ������������;
		public V82.������������/*������*/.������������� �������������;
		public V82.������������/*������*/.����������������������� �����������������������;//����������� ������������
		public bool ������������;//���� �� ������
		public bool ����������������;//���� �� ����������
		///<summary>
		///������ ������ ��������
		///</summary>
		public V82.�����������������.������ ������;
		public V82.������������/*������*/.������������������� ������������������;//������ ������������
		///<summary>
		///����������������� ����� ������������ �� �������� (� �������� ������������)
		///</summary>
		public decimal/*(10)*/ ����������������������;//����������������� �����
		///<summary>
		///������ ��������� ������������
		///</summary>
		public DateTime �����������;//������ �����
		///<summary>
		///����� ��������� ������������
		///</summary>
		public DateTime ����������;//����� �����
		///<summary>
		///������� ����� ���������� ��� ��������
		///</summary>
		public decimal/*(6.3)*/ ���������������;//����� ����������, %
		///<summary>
		///������� ������������� ��������� ������� ������ ����� ��� ��������
		///</summary>
		public bool �������������������������;//������������ ����� ��������
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
						Insert Into _Reference255(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3860RRef
						,_Fld3861RRef
						,_Fld3862
						,_Fld3863
						,_Fld3864RRef
						,_Fld3865RRef
						,_Fld3866
						,_Fld3867
						,_Fld3868
						,_Fld3869
						,_Fld3870)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@�������������
						,@�����������������������
						,@������������
						,@����������������
						,@������
						,@������������������
						,@����������������������
						,@�����������
						,@����������
						,@���������������
						,@�������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference255
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3860RRef	= @�������������
						,_Fld3861RRef	= @�����������������������
						,_Fld3862	= @������������
						,_Fld3863	= @����������������
						,_Fld3864RRef	= @������
						,_Fld3865RRef	= @������������������
						,_Fld3866	= @����������������������
						,_Fld3867	= @�����������
						,_Fld3868	= @����������
						,_Fld3869	= @���������������
						,_Fld3870	= @�������������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("���������", ���������?new byte[]{0}:new byte[]{1});
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�������������", �������������.����());
					�������.Parameters.AddWithValue("�����������������������", �����������������������.����());
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("������������������", ������������������.����());
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("�������������������������", �������������������������);
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
					�������.CommandText = @"Delete _Reference255
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
