
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class ��������������������:����������������
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
		public bool ������;
		public bool �����������;
		public bool ���������;
		public bool ������������;
		public ����������������� ����������;//���� ������
		public ����������������� ��������;//���� ����
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
						Insert Into _Reference186(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3147
						,_Fld3148
						,_Fld3149
						,_Fld3150
						,_Fld3151
						,_Fld3152)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@������
						,@�����������
						,@���������
						,@������������
						,@����������
						,@��������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference186
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3147	= @������
						,_Fld3148	= @�����������
						,_Fld3149	= @���������
						,_Fld3150	= @������������
						,_Fld3151	= @����������
						,_Fld3152	= @��������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������", ������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("���������", ���������);
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
					�������.CommandText = @"Delete _Reference186
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
