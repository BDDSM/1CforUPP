
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
		public string/*100*/ ������������;
		public string/*(150)*/ ����������������������;//��������� �� �����������
		public bool ���������������������������;//��������� ������ � �����������
		public string/*(0)*/ ����������;
		public bool ����������������������������;//���������� ������ � �����������
		public V82.�����������������.����������� �����������;
		public bool �������;
		public string/*(255)*/ ���������;
		public string/*(50)*/ ������������������;//������ ������������
		///<summary>
		///������������, ���� �������� ���������� �������
		///</summary>
		public V82.�����������������.������������ ������������;
		public bool ���������������������������;//��������� ������ ������������
		///<summary>
		///�������� ������ �����������
		///</summary>
		public ����������������� ���������������;//���� �����������
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
						Insert Into _Reference228(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Description
						,_Fld3409
						,_Fld3410
						,_Fld3411
						,_Fld3412
						,_Fld3413RRef
						,_Fld3414
						,_Fld3415
						,_Fld3416
						,_Fld3417RRef
						,_Fld3418
						,_Fld3419)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@������������
						,@����������������������
						,@���������������������������
						,@����������
						,@����������������������������
						,@�����������
						,@�������
						,@���������
						,@������������������
						,@������������
						,@���������������������������
						,@���������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference228
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Description	= @������������
						,_Fld3409	= @����������������������
						,_Fld3410	= @���������������������������
						,_Fld3411	= @����������
						,_Fld3412	= @����������������������������
						,_Fld3413RRef	= @�����������
						,_Fld3414	= @�������
						,_Fld3415	= @���������
						,_Fld3416	= @������������������
						,_Fld3417RRef	= @������������
						,_Fld3418	= @���������������������������
						,_Fld3419	= @���������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("����������������������", ����������������������);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("����������������������������", ����������������������������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("���������", ���������);
					�������.Parameters.AddWithValue("������������������", ������������������);
					�������.Parameters.AddWithValue("������������", ������������.������);
					�������.Parameters.AddWithValue("���������������������������", ���������������������������);
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
					�������.CommandText = @"Delete _Reference228
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
	}
}
