
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.������������;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.���������������
{
	public partial class ���������������: ��������������
	{

		public static void �������1000()
		{
			var ����� = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("�������� 1000 ��������� ����������� ���������������. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var ������������� = 1;������������� < 1000;�������������++)
			{
				var ������ = V82.�����������/*��������*/.���������������.��������������();
				������.��� = �����������������������.���������(999);//�������������;
				������.������������ = �����������������������.���������������������(3, 25);//"������������ " + �������������.ToString();


				������.��������();
				Console.Write("���������: " + �������������.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var ����� = DateTime.Now;
			Console.WriteLine("��������� " + Math.Round(((����� - �����).TotalMilliseconds / 1000), 3).ToString() + " ���. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void �������1000()
		{
			foreach (var ������ in V82.�����������/*��������*/.���������������.�������())
			{
				var ������ = ������.��������������();
				������.�������();
			}
		}

		public static void ������������ProtoBuf1000()
		{
			var ����� = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("������������ProtoBuf 1000 ��������� ����������� ���������������. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var ����� = new MemoryStream())
			{
				var ������������� = 0;
				foreach (var ������ in V82.�����������/*��������*/.���������������.�������())
				{
					�������������++;
					������.������������ProtoBuf(�����);
					Console.Write("���������: " + �������������.ToString() + "%.");
					Console.CursorLeft = 0;
				}
			}
			var ����� = DateTime.Now;
			Console.WriteLine("��������� " + Math.Round(((����� - �����).TotalMilliseconds / 1000), 3).ToString() + " ���. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void ������������Json1000()
		{
			var ����� = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("������������Json 1000 ��������� ����������� ���������������. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var ������������� = 0;
			foreach (var ������ in V82.�����������/*��������*/.���������������.�������())
			{
				�������������++;
				������.������������Json();
				Console.Write("���������: " + �������������.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var ����� = DateTime.Now;
			Console.WriteLine("��������� " + Math.Round(((����� - �����).TotalMilliseconds / 1000), 3).ToString() + " ���. �����: " + �����.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}
