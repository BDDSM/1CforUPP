
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
		public string/*50*/ ������������;
		public V82.�����������������.������������ ������������;//������ ������
		public V82.�����������������.�������������������� ��������������������;//�������������� ������
		public V82.�����������������.���������������������������������� �������������������������;//������ ������������� ������
		public V82.�����������������.�������������������� �������������������;//������ �������������
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
						Insert Into _Reference242(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld3710RRef
						,_Fld3711RRef
						,_Fld3712RRef
						,_Fld3713RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@������������
						,@������������
						,@��������������������
						,@�������������������������
						,@�������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference242
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Description	= @������������
						,_Fld3710RRef	= @������������
						,_Fld3711RRef	= @��������������������
						,_Fld3712RRef	= @�������������������������
						,_Fld3713RRef	= @�������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������", ������������.������);
					�������.Parameters.AddWithValue("��������������������", ��������������������.������);
					�������.Parameters.AddWithValue("�������������������������", �������������������������.������);
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
					�������.CommandText = @"Delete _Reference242
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
