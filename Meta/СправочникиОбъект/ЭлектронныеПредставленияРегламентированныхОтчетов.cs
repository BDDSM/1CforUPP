
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	public partial class �������������������������������������������������:����������������
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
		public string/*8*/ ���;
		public string/*150*/ ������������;
		public V82.�����������������.����������� �����������;
		public object ����������;
		public object ���������;//��� ������
		public DateTime ����������;//���� ������
		public DateTime �������������;//���� ���������
		public decimal/*(3)*/ ������;
		public string/*(0)*/ �����������;
		public V82.������������/*������*/.������������� �������������;
		public DateTime �����������;//���� �������
		public V82.������������/*������*/.������������������������� �������������;//��� ����������
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
						Insert Into _Reference295(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld4337RRef
						,_Fld4338RRef
						,_Fld4339RRef
						,_Fld4340
						,_Fld4341
						,_Fld4342
						,_Fld4343
						,_Fld4344RRef
						,_Fld4345
						,_Fld4346RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�����������
						,@����������
						,@���������
						,@����������
						,@�������������
						,@������
						,@�����������
						,@�������������
						,@�����������
						,@�������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference295
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld4337RRef	= @�����������
						,_Fld4338RRef	= @����������
						,_Fld4339RRef	= @���������
						,_Fld4340	= @����������
						,_Fld4341	= @�������������
						,_Fld4342	= @������
						,_Fld4343	= @�����������
						,_Fld4344RRef	= @�������������
						,_Fld4345	= @�����������
						,_Fld4346RRef	= @�������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("����������", ����������.������);
					�������.Parameters.AddWithValue("���������", ���������.������);
					�������.Parameters.AddWithValue("����������", ����������);
					�������.Parameters.AddWithValue("�������������", �������������);
					�������.Parameters.AddWithValue("������", ������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�������������", �������������.����());
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�������������", �������������.����());
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
					�������.CommandText = @"Delete _Reference295
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

		public void ���������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������� <> ������������*/)
			{
				/*�����������.����������������(����������, �����);*/
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
