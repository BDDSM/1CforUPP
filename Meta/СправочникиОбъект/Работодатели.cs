
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ������������:����������������
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
		public string/*(12)*/ ���;
		///<summary>
		///(����)
		///</summary>
		public string/*(9)*/ ���;
		public string/*(135)*/ �������������������������������������;//������������ ���������������� ������ ���
		///<summary>
		///(����)
		///</summary>
		public string/*(14)*/ �����������������������;//��������������� ����� ���
		///<summary>
		///(����)
		///</summary>
		public string/*(14)*/ ��������������������;//�������������� ��� ���
		///<summary>
		///(����)
		///</summary>
		public string/*(5)*/ �������������������;//��� ������������� ���
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
						Insert Into _Reference212(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3314
						,_Fld3315
						,_Fld3316
						,_Fld3317
						,_Fld3318
						,_Fld3319
						,_Fld3320)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@������������������
						,@���
						,@���
						,@�������������������������������������
						,@�����������������������
						,@��������������������
						,@�������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference212
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3314	= @������������������
						,_Fld3315	= @���
						,_Fld3316	= @���
						,_Fld3317	= @�������������������������������������
						,_Fld3318	= @�����������������������
						,_Fld3319	= @��������������������
						,_Fld3320	= @�������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("�������������������������������������", �������������������������������������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������);
					�������.Parameters.AddWithValue("��������������������", ��������������������);
					�������.Parameters.AddWithValue("�������������������", �������������������);
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
					�������.CommandText = @"Delete _Reference212
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
