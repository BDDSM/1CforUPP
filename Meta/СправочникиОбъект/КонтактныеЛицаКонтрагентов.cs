
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
	///���������� ���� ������������
	///</summary>
	public partial class ��������������������������:����������������
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
		public string/*(100)*/ ���������;
		public string/*(0)*/ �����������;
		public V82.�����������������.�������������� ��������������;//���������� ����
		public V82.�����������������.����������������� �������������������;//���� ����������� ����
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
						Insert Into _Reference129(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2458
						,_Fld2459
						,_Fld2460RRef
						,_Fld2461RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@���������
						,@�����������
						,@��������������
						,@�������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference129
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2458	= @���������
						,_Fld2459	= @�����������
						,_Fld2460RRef	= @��������������
						,_Fld2461RRef	= @�������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("���������", ���������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("��������������", ��������������.������);
					�������.Parameters.AddWithValue("�������������������", �������������������.������);
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
					�������.CommandText = @"Delete _Reference129
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
