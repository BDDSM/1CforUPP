
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ���������������:����������������
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
		public string/*4*/ ���;
		public string/*120*/ ������������;
		public V82.�����������������.�������������������� ���;//��� ���������� ������
		public string/*(250)*/ ������������������;//������ ������������
		public bool ����������������������;//���� ������������������
		public bool ������������������������;//����� ��������� ����������
		public string/*(10)*/ ���;
		public string/*(9)*/ ���;
		public string/*(128)*/ �����;
		public string/*(64)*/ �������;
		public string/*(64)*/ ���������������������;//����� ����������� �����
		public string/*(64)*/ ����������;//����� �����
		public string/*(250)*/ �����������;
		public string/*(40)*/ �����������������;//������� ����������
		public string/*(254)*/ �����������������������������������������������������������������;//����� ����������� ����� ��� ����� ���������������� � �������������������
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
						Insert Into _Reference144(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld2574RRef
						,_Fld2575
						,_Fld2576
						,_Fld2577
						,_Fld2578
						,_Fld2579
						,_Fld2580
						,_Fld2581
						,_Fld2582
						,_Fld2583
						,_Fld2584
						,_Fld2585
						,_Fld2586)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@���
						,@������������������
						,@����������������������
						,@������������������������
						,@���
						,@���
						,@�����
						,@�������
						,@���������������������
						,@����������
						,@�����������
						,@�����������������
						,@�����������������������������������������������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference144
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2574RRef	= @���
						,_Fld2575	= @������������������
						,_Fld2576	= @����������������������
						,_Fld2577	= @������������������������
						,_Fld2578	= @���
						,_Fld2579	= @���
						,_Fld2580	= @�����
						,_Fld2581	= @�������
						,_Fld2582	= @���������������������
						,_Fld2583	= @����������
						,_Fld2584	= @�����������
						,_Fld2585	= @�����������������
						,_Fld2586	= @�����������������������������������������������������������������
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
					�������.Parameters.AddWithValue("���", ���.������);
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("������������������������", ������������������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("�����", �����);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("���������������������", ���������������������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("�����������������������������������������������������������������", �����������������������������������������������������������������);
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
					�������.CommandText = @"Delete _Reference144
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
