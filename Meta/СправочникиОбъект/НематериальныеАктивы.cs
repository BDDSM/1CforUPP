
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
		///<summary>
		///(���)
		///</summary>
		public string/*(0)*/ ������������������;//������ ������������
		///<summary>
		///(����)
		///</summary>
		public V82.������������/*������*/.������� ������;//��� ���
		///<summary>
		///(����)
		///</summary>
		public V82.������������/*������*/.��������������������� ���������������������;//��������������� ������
		///<summary>
		///(���)
		///</summary>
		public string/*(0)*/ ��������������;//������ ��������
		public V82.������������/*������*/.�������������������� ���������������;//��� ������� �����
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
						Insert Into _Reference161(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld2898
						,_Fld2899RRef
						,_Fld2900RRef
						,_Fld2901
						,_Fld2902RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@������������������
						,@������
						,@���������������������
						,@��������������
						,@���������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference161
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2898	= @������������������
						,_Fld2899RRef	= @������
						,_Fld2900RRef	= @���������������������
						,_Fld2901	= @��������������
						,_Fld2902RRef	= @���������������
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
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("������", ������.����());
					�������.Parameters.AddWithValue("���������������������", ���������������������.����());
					�������.Parameters.AddWithValue("��������������", ��������������);
					�������.Parameters.AddWithValue("���������������", ���������������.����());
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
					�������.CommandText = @"Delete _Reference161
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
