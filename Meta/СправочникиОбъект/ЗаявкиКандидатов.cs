
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
	public partial class ����������������:����������������
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
		public V82.�����������������.�������������� �������;//���������� ����
		public V82.�����������������.������������������������� ���������;//������� ���������
		public V82.������������/*������*/.�������� ��������;
		public string/*(0)*/ �����������;//�������� ���������
		public bool �������;//������ �� ��������� ���������
		public string/*(0)*/ �����������������;//��������� ������ �� ���������
		public V82.�����������������.���������������������� ������������;//������ ����������
		public DateTime ������������;//���� ����������� ���������
		public V82.�����������������.������������������� ������������������;//�������� ����������
		public V82.�����������������.�������� ��������;
		public object �������������;
		public V82.�����������������.��������� ���������;
		public V82.�����������������.����������� �����������;
		public V82.�����������������.������������ �������������;
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
						Insert Into _Reference100(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2325RRef
						,_Fld2326RRef
						,_Fld2327RRef
						,_Fld2328
						,_Fld2329
						,_Fld2330
						,_Fld2331RRef
						,_Fld2332
						,_Fld2333RRef
						,_Fld2334RRef
						,_Fld2335RRef
						,_Fld2336RRef
						,_Fld2337RRef
						,_Fld2338RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�������
						,@���������
						,@��������
						,@�����������
						,@�������
						,@�����������������
						,@������������
						,@������������
						,@������������������
						,@��������
						,@�������������
						,@���������
						,@�����������
						,@�������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference100
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2325RRef	= @�������
						,_Fld2326RRef	= @���������
						,_Fld2327RRef	= @��������
						,_Fld2328	= @�����������
						,_Fld2329	= @�������
						,_Fld2330	= @�����������������
						,_Fld2331RRef	= @������������
						,_Fld2332	= @������������
						,_Fld2333RRef	= @������������������
						,_Fld2334RRef	= @��������
						,_Fld2335RRef	= @�������������
						,_Fld2336RRef	= @���������
						,_Fld2337RRef	= @�����������
						,_Fld2338RRef	= @�������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�������", �������.������);
					�������.Parameters.AddWithValue("���������", ���������.������);
					�������.Parameters.AddWithValue("��������", ��������.����());
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("������������", ������������.������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������������������", ������������������.������);
					�������.Parameters.AddWithValue("��������", ��������.������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
					�������.Parameters.AddWithValue("���������", ���������.������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
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
					�������.CommandText = @"Delete _Reference100
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
