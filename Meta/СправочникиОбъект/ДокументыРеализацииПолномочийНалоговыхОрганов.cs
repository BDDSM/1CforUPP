
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ���������������������������������������������:����������������
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
		public string/*150*/ ������������;
		public V82.�����������������.��������������� ��������������;//��������� �����
		public V82.�����������������.����������� �����������;
		public string/*(150)*/ �������������;
		public string/*(150)*/ ����������������������;//������������� ���������
		///<summary>
		///��� ���������� ���������
		///</summary>
		public object ������������;//��� ���������
		public string/*(150)*/ ��������������;//����� ���������
		public DateTime �������������;//���� ���������
		public DateTime �������������;//���� ���������
		public DateTime ������������;//���� ��������
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
						Insert Into _Reference89(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2249RRef
						,_Fld2250RRef
						,_Fld2251
						,_Fld2252
						,_Fld2253RRef
						,_Fld2254
						,_Fld2255
						,_Fld2256
						,_Fld2257)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@��������������
						,@�����������
						,@�������������
						,@����������������������
						,@������������
						,@��������������
						,@�������������
						,@�������������
						,@������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference89
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2249RRef	= @��������������
						,_Fld2250RRef	= @�����������
						,_Fld2251	= @�������������
						,_Fld2252	= @����������������������
						,_Fld2253RRef	= @������������
						,_Fld2254	= @��������������
						,_Fld2255	= @�������������
						,_Fld2256	= @�������������
						,_Fld2257	= @������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("��������������", ��������������.������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("������������", ������������.����());
					�������.Parameters.AddWithValue("��������������", ��������������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("������������", ������������);
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
					�������.CommandText = @"Delete _Reference89
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� <> ������������*/)
			{
				/*�����������.�������������������(����������, �����);*/
			}
			/*#���������;*/
		}

		public void �������������������(/*������������������*/)
		{
			if(true/*����������� <> ������������*/)
			{
				/*�����������.��������������������������(����������, ������������������);*/
			}
			/*#���������;*/
		}
	}
}
