
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum �����������������������
	{
		������������ = - 1,
		TXT = 0,//��������� ��������
		PDF = 1,//�������� PDF
		RTF = 2,//�������� RTF
		XML = 3,//�������� XML
		HTML = 4,//�������� HTML
		XLS = 5,//�������� XLS
	}
	public static partial class �����������������������_��������//:������������������
	{
		public static readonly Guid TXT = new Guid("228afeab-cfb7-6e48-42e0-a6832fb7d226");//��������� ��������
		public static readonly Guid PDF = new Guid("628651be-4cf0-a1fc-46eb-6abade8ddc6a");//�������� PDF
		public static readonly Guid RTF = new Guid("239a03af-419e-6609-4a71-80af597e918c");//�������� RTF
		public static readonly Guid XML = new Guid("4f3426be-b67e-f5e7-41af-c98847cf54e0");//�������� XML
		public static readonly Guid HTML = new Guid("254bb2ab-3fc3-88a7-49c8-fa11c7445b5a");//�������� HTML
		public static readonly Guid XLS = new Guid("8f43fb89-c05c-b0ea-4ec2-a16b653330a1");//�������� XLS
		public static ����������������������� ��������(this ����������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������� ��������(this ����������������������� ��������, Guid ������)
		{
			if(������ == TXT)
			{
				return �����������������������.TXT;
			}
			else if(������ == PDF)
			{
				return �����������������������.PDF;
			}
			else if(������ == RTF)
			{
				return �����������������������.RTF;
			}
			else if(������ == XML)
			{
				return �����������������������.XML;
			}
			else if(������ == HTML)
			{
				return �����������������������.HTML;
			}
			else if(������ == XLS)
			{
				return �����������������������.XLS;
			}
			return �����������������������.������������;
		}
		public static byte[] ����(this ����������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������� ��������)
		{
			switch (��������)
			{
				case �����������������������.TXT: return TXT;
				case �����������������������.PDF: return PDF;
				case �����������������������.RTF: return RTF;
				case �����������������������.XML: return XML;
				case �����������������������.HTML: return HTML;
				case �����������������������.XLS: return XLS;
			}
			return Guid.Empty;
		}
	}
}
