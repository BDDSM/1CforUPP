
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
		public string/*(50)*/ ��������;
		public DateTime ������������;//���� ��������
		public string/*(0)*/ ��������;
		public bool ����������������������;//���������� � ��� ��������
		public decimal/*(2)*/ ���������������������������;//���������� ���� �� �����������
		public V82.�����������������.������������ �������������������������������������;//������������ ��� ����������� ���� �������
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
						Insert Into _Reference133(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2519
						,_Fld2520
						,_Fld2521
						,_Fld2522
						,_Fld2523
						,_Fld2524
						,_Fld2525
						,_Fld2526RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�������
						,@���
						,@��������
						,@������������
						,@��������
						,@����������������������
						,@���������������������������
						,@�������������������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference133
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2519	= @�������
						,_Fld2520	= @���
						,_Fld2521	= @��������
						,_Fld2522	= @������������
						,_Fld2523	= @��������
						,_Fld2524	= @����������������������
						,_Fld2525	= @���������������������������
						,_Fld2526RRef	= @�������������������������������������
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
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
					�������.Parameters.AddWithValue("�������������������������������������", �������������������������������������.������);
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
					�������.CommandText = @"Delete _Reference133
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		// ���������� ������� "������������" �������
		//

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			/*������������������������������������� = ��������������������("���������������������");*/
		}
	}
}
