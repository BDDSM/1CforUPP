
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
	public partial class �����������������������:����������������
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
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.������������ ����������������������������������;//�������� ������ ������ �� ������������
		///<summary>
		///(����)
		///</summary>
		public V82.�����������������.���������������������������������� ��������������������������������;//������ ��������� �������� � ��������
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.���������������������������������� �����������������������������������������;//�������� ������ ������������� ������ �� ������
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.�������������������� ����������������������������;//�������� �������������� ������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(15.3)*/ ��������;
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.���������������������������� �����������������������;//������� ������� ���������
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.������ ������;
		///<summary>
		///(���)
		///</summary>
		public decimal/*(10)*/ ������������;//����� �������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(10.3)*/ �����������;
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
						Insert Into _Reference264(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3906RRef
						,_Fld3907RRef
						,_Fld3908RRef
						,_Fld3909RRef
						,_Fld3910
						,_Fld3911RRef
						,_Fld3912RRef
						,_Fld3913
						,_Fld3914)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@����������������������������������
						,@��������������������������������
						,@�����������������������������������������
						,@����������������������������
						,@��������
						,@�����������������������
						,@������
						,@������������
						,@�����������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference264
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3906RRef	= @����������������������������������
						,_Fld3907RRef	= @��������������������������������
						,_Fld3908RRef	= @�����������������������������������������
						,_Fld3909RRef	= @����������������������������
						,_Fld3910	= @��������
						,_Fld3911RRef	= @�����������������������
						,_Fld3912RRef	= @������
						,_Fld3913	= @������������
						,_Fld3914	= @�����������
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
					�������.Parameters.AddWithValue("����������������������������������", ����������������������������������.������);
					�������.Parameters.AddWithValue("��������������������������������", ��������������������������������.������);
					�������.Parameters.AddWithValue("�����������������������������������������", �����������������������������������������.������);
					�������.Parameters.AddWithValue("����������������������������", ����������������������������.������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������.������);
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
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
					�������.CommandText = @"Delete _Reference264
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
