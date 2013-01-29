
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������
	{
		������������ = - 1,
		XML = 0,//CommerceML (*.xml)
		PDF = 1,//�������� PDF (*.pdf)
		HTML = 2,//�������� HTML (*.html)
		DOCX = 3,//�������� Word 2007 (*.docx)
		XLS = 4,//���� Excel (*.xls)
		MXL = 5,//��������� �������� (*.mxl)
		ODS = 6,//����������� ������� ODF (*.ods)
		��������������� = 7,//��������� ������ (*.zip)
	}
	public static partial class ���������������������_��������//:������������������
	{
		public static readonly Guid XML = new Guid("158a9c8b-2830-3802-4ced-1992ed01e9ad");//CommerceML (*.xml)
		public static readonly Guid PDF = new Guid("b9506fb7-2ec4-a1eb-45d3-a38206f29af8");//�������� PDF (*.pdf)
		public static readonly Guid HTML = new Guid("e1a358ad-f8b4-bdb6-423c-a6a4838076fe");//�������� HTML (*.html)
		public static readonly Guid DOCX = new Guid("1ee453a7-afe0-57db-4cd1-94039009a50f");//�������� Word 2007 (*.docx)
		public static readonly Guid XLS = new Guid("f58f408a-9927-91c4-49b1-925532d7e45c");//���� Excel (*.xls)
		public static readonly Guid MXL = new Guid("715ffa85-82c1-c392-416b-d75a4064fee8");//��������� �������� (*.mxl)
		public static readonly Guid ODS = new Guid("32b52d87-4a8c-b173-4691-f1bfd7cb9c3f");//����������� ������� ODF (*.ods)
		public static readonly Guid ��������������� = new Guid("4b0a54b2-ac71-2917-4019-6bafa148b163");//��������� ������ (*.zip)
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == XML)
			{
				return ���������������������.XML;
			}
			else if(������ == PDF)
			{
				return ���������������������.PDF;
			}
			else if(������ == HTML)
			{
				return ���������������������.HTML;
			}
			else if(������ == DOCX)
			{
				return ���������������������.DOCX;
			}
			else if(������ == XLS)
			{
				return ���������������������.XLS;
			}
			else if(������ == MXL)
			{
				return ���������������������.MXL;
			}
			else if(������ == ODS)
			{
				return ���������������������.ODS;
			}
			else if(������ == ���������������)
			{
				return ���������������������.���������������;
			}
			return ���������������������.������������;
		}
		public static byte[] ����(this ��������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������.XML: return XML;
				case ���������������������.PDF: return PDF;
				case ���������������������.HTML: return HTML;
				case ���������������������.DOCX: return DOCX;
				case ���������������������.XLS: return XLS;
				case ���������������������.MXL: return MXL;
				case ���������������������.ODS: return ODS;
				case ���������������������.���������������: return ���������������;
			}
			return Guid.Empty;
		}
	}
}
