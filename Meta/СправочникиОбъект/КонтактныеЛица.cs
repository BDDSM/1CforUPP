
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ��������������:����������������
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
		public string/*(50)*/ �������;
		public string/*(50)*/ ���;
		public decimal/*(2)*/ ���������������������������;//���������� ���� �� �����������
		public bool ����������������������;//���������� � ��� ��������
		public string/*(50)*/ ��������;
		public DateTime ������������;//���� ��������
		public string/*(0)*/ ��������;
		///<summary>
		///(���)
		///</summary>
		public V82.������������/*������*/.���������������� ���;
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
						Insert Into _Reference128(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2448
						,_Fld2449
						,_Fld2450
						,_Fld2451
						,_Fld2452
						,_Fld2453
						,_Fld2454
						,_Fld2455RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�������
						,@���
						,@���������������������������
						,@����������������������
						,@��������
						,@������������
						,@��������
						,@���)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference128
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2448	= @�������
						,_Fld2449	= @���
						,_Fld2450	= @���������������������������
						,_Fld2451	= @����������������������
						,_Fld2452	= @��������
						,_Fld2453	= @������������
						,_Fld2454	= @��������
						,_Fld2455RRef	= @���
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("���", ���.����());
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
					�������.CommandText = @"Delete _Reference128
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
