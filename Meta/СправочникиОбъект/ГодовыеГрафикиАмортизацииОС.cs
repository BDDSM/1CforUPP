
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
	public partial class ���������������������������:����������������
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
		///<summary>
		///(���)
		///</summary>
		public string/*(0)*/ �����������;//������ ��������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������1;//������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������2;//�������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������3;//����
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������4;//������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������5;//���
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������6;//����
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������7;//����
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������8;//������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������9;//��������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������10;//�������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������11;//������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(6.3)*/ �����������12;//�������
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
						Insert Into _Reference71(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2029
						,_Fld2030
						,_Fld2031
						,_Fld2032
						,_Fld2033
						,_Fld2034
						,_Fld2035
						,_Fld2036
						,_Fld2037
						,_Fld2038
						,_Fld2039
						,_Fld2040
						,_Fld2041)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�����������
						,@�����������1
						,@�����������2
						,@�����������3
						,@�����������4
						,@�����������5
						,@�����������6
						,@�����������7
						,@�����������8
						,@�����������9
						,@�����������10
						,@�����������11
						,@�����������12)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference71
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2029	= @�����������
						,_Fld2030	= @�����������1
						,_Fld2031	= @�����������2
						,_Fld2032	= @�����������3
						,_Fld2033	= @�����������4
						,_Fld2034	= @�����������5
						,_Fld2035	= @�����������6
						,_Fld2036	= @�����������7
						,_Fld2037	= @�����������8
						,_Fld2038	= @�����������9
						,_Fld2039	= @�����������10
						,_Fld2040	= @�����������11
						,_Fld2041	= @�����������12
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�����������1", �����������1);
					�������.Parameters.AddWithValue("�����������2", �����������2);
					�������.Parameters.AddWithValue("�����������3", �����������3);
					�������.Parameters.AddWithValue("�����������4", �����������4);
					�������.Parameters.AddWithValue("�����������5", �����������5);
					�������.Parameters.AddWithValue("�����������6", �����������6);
					�������.Parameters.AddWithValue("�����������7", �����������7);
					�������.Parameters.AddWithValue("�����������8", �����������8);
					�������.Parameters.AddWithValue("�����������9", �����������9);
					�������.Parameters.AddWithValue("�����������10", �����������10);
					�������.Parameters.AddWithValue("�����������11", �����������11);
					�������.Parameters.AddWithValue("�����������12", �����������12);
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
					�������.CommandText = @"Delete _Reference71
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
