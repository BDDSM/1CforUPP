
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	///<summary>
	///�������� �� ����� ��� �������� ������
	///</summary>
	public partial class ������������������:������������������
	{

		public static �����������������.������������������ �����������(decimal ���)
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������]
					,_Fld3985 [�����������]
					,_Fld3986 [������������������]
					,_Fld3987 [����������Linux]
					,_Fld3988 [����������Windows]
					,_Fld3989 [�����������������]
					From _Reference271(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.������������������ = �������.GetDecimal(7);
							������.����������Linux = �������.GetString(8);
							������.����������Windows = �������.GetString(9);
							������.����������������� = �������.GetDecimal(10);
							return ������;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static ������������������.������������������ �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1000 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������],_Fld3985 [�����������],_Fld3986 [������������������],_Fld3987 [����������Linux],_Fld3988 [����������Windows],_Fld3989 [�����������������]
		 From _Reference271(NOLOCK)";
					var ������� = new V82.������������������.������������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.����������� = �������.GetString(6);
							������.������������������ = �������.GetDecimal(7);
							������.����������Linux = �������.GetString(8);
							������.����������Windows = �������.GetString(9);
							������.����������������� = �������.GetDecimal(10);
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.������������������ ��������������()
		{
			var ������ = new V82.�����������������.������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.����������� = "";
			������.����������Linux = "";
			������.����������Windows = "";
			return ������;
		}
	}
}
