
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
	///�������� ����������� �����
	///</summary>
	public partial class ������������������������:����������������
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
		public string/*100*/ ������������;
		///<summary>
		///������
		///</summary>
		public V82.���������������.����������������� ������;
		///<summary>
		///��� �����
		///</summary>
		public string/*(0)*/ ��������;//��� �����
		///<summary>
		///���������
		///</summary>
		public ����������������� ���������;
		public string/*(200)*/ ����������������������;//������� ��������� ������
		public object �������;
		public ����������������� ����������;//����� �����
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
						Insert Into _Reference67(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld1986RRef
						,_Fld1987
						,_Fld1988
						,_Fld1989
						,_Fld1990RRef
						,_Fld1991)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@������������
						,@������
						,@��������
						,@���������
						,@����������������������
						,@�������
						,@����������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference67
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Description	= @������������
						,_Fld1986RRef	= @������
						,_Fld1987	= @��������
						,_Fld1988	= @���������
						,_Fld1989	= @����������������������
						,_Fld1990RRef	= @�������
						,_Fld1991	= @����������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("�������", �������.������);
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
					�������.CommandText = @"Delete _Reference67
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
			if(true/*������(������) = ���("��������������.�����������������")
	   � ������(������.���������������) = ���("����������������.��������������")*/)
			{
				/*������� = ������.���������������;*/
			}
		}
	}
}
