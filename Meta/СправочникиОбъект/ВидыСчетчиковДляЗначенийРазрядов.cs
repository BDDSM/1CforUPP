
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ��������������������������������:����������������
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
		public string/*50*/ ������������;
		public decimal/*(2)*/ ��������������;//������ ��������
		public bool ��������������������;//� �������� �����������
		public bool ����������������������;//� �������� �������������
		public bool �����������������������������;//� �������� �������������� ������
		public bool ���������������������;//� �������� ������������
		public decimal/*(20)*/ �����������������;//��������� ��������
		public decimal/*(20)*/ ����������������;//�������� ��������
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
						Insert Into _Reference64(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld1975
						,_Fld1976
						,_Fld1977
						,_Fld1978
						,_Fld1979
						,_Fld1980
						,_Fld1981)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@��������������
						,@��������������������
						,@����������������������
						,@�����������������������������
						,@���������������������
						,@�����������������
						,@����������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference64
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld1975	= @��������������
						,_Fld1976	= @��������������������
						,_Fld1977	= @����������������������
						,_Fld1978	= @�����������������������������
						,_Fld1979	= @���������������������
						,_Fld1980	= @�����������������
						,_Fld1981	= @����������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("��������������", ��������������);
					�������.Parameters.AddWithValue("��������������������", ��������������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("�����������������������������", �����������������������������);
					�������.Parameters.AddWithValue("���������������������", ���������������������);
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
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
					�������.CommandText = @"Delete _Reference64
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
