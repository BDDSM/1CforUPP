
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
	public partial class �������������:����������������
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
		public V82.������������/*������*/.����������������� ����������������;//��� �������������
		public V82.�����������������.������� ������;//��� ���
		public object ��������������;//�������� ������
		public decimal/*(6)*/ �������;
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
						Insert Into _Reference191(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3195RRef
						,_Fld3196RRef
						,_Fld3197RRef
						,_Fld3198)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@����������������
						,@������
						,@��������������
						,@�������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference191
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3195RRef	= @����������������
						,_Fld3196RRef	= @������
						,_Fld3197RRef	= @��������������
						,_Fld3198	= @�������
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
					�������.Parameters.AddWithValue("����������������", ����������������.����());
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("��������������", ��������������.������);
					�������.Parameters.AddWithValue("�������", �������);
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
					�������.CommandText = @"Delete _Reference191
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		////////////////////////////////////////////////////////////////////////////////
		// ���������� ������

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			/*��������������������������������������� = ?(�� ��������() � �� ������.�������� = ��������, ������.��������, ������������);*/
			/*��������������������.�����������������������������������������������������(����������, �����, ��������);*/
			if(true/*�� �����*/)
			{
				/*����������������.��������������������������(�����, ����������, ���������������������);*/
			}
		}

		public void ���������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			/*��������������������.����������������������������������������������������������(������, ���������������������������������������, �����);*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// ��������� �������� ���������
	}
}
