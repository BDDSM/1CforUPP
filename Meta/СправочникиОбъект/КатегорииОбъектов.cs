
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
		public string/*50*/ ������������;
		///<summary>
		///(���)
		///</summary>
		public object �������������������;//���������� ���������
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
						Insert Into _Reference111(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2392RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference111
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld2392RRef	= @�������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
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
					�������.CommandText = @"Delete _Reference111
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		////////////////////////////////////////////////////////////////////////////////
		// ����������� �������
		// ���������� ������� ������������ �������.
		//

		public void ������������(/*�����*/)
		{
			if(true/*�� ������������.��������
	   � �� ��������() 
	   � ������������������� <> ������.������������������� 
	   � �����������.���������_����������������(������)*/)
			{
				/*��������("���������� �������, ������� ��������� ��������� """ + ������������ + """.
		         |���������� ��������� �� ����� ���� ��������.", 
		         ���������������.��������);*/
				/*����� = ������;*/
			}
		}
		////////////////////////////////////////////////////////////////////////////////
	}
}
