
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
	public partial class �����������������:����������������
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
		public string/*25*/ ������������;
		///<summary>
		///(���) ������, � ������� ������ ������ 
		///</summary>
		public V82.�����������������.������ ������;
		///<summary>
		///������� (���) ������ -  ������ ��������� ��� ���� �������������� �������, ����� - ������ ��� �������� � �������� �������� ������
		///</summary>
		public bool �������������������;//��� ���� ������������
		///<summary>
		///(���) ������� ������ �� ��������� (����� ��� �������)
		///</summary>
		public decimal/*(15.2)*/ ��������������������;//������� ������ �������
		///<summary>
		///(���) �������� ������� ������
		///</summary>
		public object ���������������;//�������� �������
		///<summary>
		///(����� ����� ������ �������� ������)
		///</summary>
		public DateTime ����������������;//����� ����� ������
		///<summary>
		///(����� ����� ��������� �������� ������)
		///</summary>
		public DateTime �������������������;//����� ����� ���������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(15.2)*/ ������������������������;//����������� ������ �������
		///<summary>
		///(���) ������� ������-�������
		///</summary>
		public V82.������������/*������*/.�������������������� �������;
		public V82.�����������������.�������� ��������;
		public bool ������������������;//��� ���� �����������
		public bool ������������;//�� ���� ������
		public V82.������������/*������*/.���������� ���������;//��� ������
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
						Insert Into _Reference268(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3946RRef
						,_Fld3947
						,_Fld3948
						,_Fld3949
						,_Fld3950
						,_Fld3951
						,_Fld3952
						,_Fld3953RRef
						,_Fld3954RRef
						,_Fld3955
						,_Fld3956
						,_Fld3957RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@������
						,@�������������������
						,@��������������������
						,@���������������
						,@����������������
						,@�������������������
						,@������������������������
						,@�������
						,@��������
						,@������������������
						,@������������
						,@���������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference268
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3946RRef	= @������
						,_Fld3947	= @�������������������
						,_Fld3948	= @��������������������
						,_Fld3949	= @���������������
						,_Fld3950	= @����������������
						,_Fld3951	= @�������������������
						,_Fld3952	= @������������������������
						,_Fld3953RRef	= @�������
						,_Fld3954RRef	= @��������
						,_Fld3955	= @������������������
						,_Fld3956	= @������������
						,_Fld3957RRef	= @���������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("�������������������", �������������������);
					�������.Parameters.AddWithValue("��������������������", ��������������������);
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("�������������������", �������������������);
					�������.Parameters.AddWithValue("������������������������", ������������������������);
					�������.Parameters.AddWithValue("�������", �������.����());
					�������.Parameters.AddWithValue("��������", ��������.������);
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("���������", ���������.����());
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
					�������.CommandText = @"Delete _Reference268
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
