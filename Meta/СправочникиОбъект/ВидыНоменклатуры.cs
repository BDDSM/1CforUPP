
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
		public string/*50*/ ������������;
		public V82.������������/*������*/.���������������� ���������������;//��� ������������
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
						Insert Into _Reference55(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld1948RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@���������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference55
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld1948RRef	= @���������������
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
					�������.Parameters.AddWithValue("���������������", ���������������.����());
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
					�������.CommandText = @"Delete _Reference55
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		// ���������� ������� ������������ �����.
		//

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*���������*/)
			{
			}
			if(true/*��  �����������������(���������������)*/)
			{
				/*�������������� = "���������� ������� ��� ������������!";*/
				/*����������������.����������������(��������������, �����);*/
			}
			/*���������������� = ������������;*/
			if(true/*�� ��������() 
	   � ��������������� <> ������.��������������� 
	   � �����������.����������������_�����������������������������(������, ����������������)*/)
			{
				/*�������������� = "��� ������������ """ + ������(������) + """ ������ � ��������� ����������� ""������������"".
		|��� �� ����� ���� �������!";*/
				/*����������������.����������������(��������������, �����);*/
			}
		}
	}
}
