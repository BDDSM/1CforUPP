
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
	///(����)
	///</summary>
	public partial class ����������:����������������
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
		public string/*20*/ ���;
		public string/*150*/ ������������;
		public V82.������������/*������*/.���������������������������������� ������������������������������;//������ ��������������� ���������
		public string/*(4)*/ ����������������;//��� ��� ����������
		public bool �����������������������������;//�� ���������� � ���������� ������
		public bool �����������������������2010;//�� ���������� � ����������-2010
		public bool ��������������������������;//��������� �� ������� ��������
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
						Insert Into _Reference95(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2297RRef
						,_Fld2298
						,_Fld2299
						,_Fld2300
						,_Fld2301)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@������������������������������
						,@����������������
						,@�����������������������������
						,@�����������������������2010
						,@��������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference95
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2297RRef	= @������������������������������
						,_Fld2298	= @����������������
						,_Fld2299	= @�����������������������������
						,_Fld2300	= @�����������������������2010
						,_Fld2301	= @��������������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������������������������", ������������������������������.����());
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("�����������������������������", �����������������������������);
					�������.Parameters.AddWithValue("�����������������������2010", �����������������������2010);
					�������.Parameters.AddWithValue("��������������������������", ��������������������������);
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
					�������.CommandText = @"Delete _Reference95
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
