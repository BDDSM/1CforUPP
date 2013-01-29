
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
	public enum ���������������������
	{
		������������ = - 1,
		�����866 = 0,//����� � ��������� DOS
		�����1251 = 1,
		xml = 2,
		html = 3,
		pdf = 4,//�������� � ������� PDF
		rtf = 5,//�������� � ������� RTF
		tiff = 6,//�������� � ������� TIFF
		jpeg = 7,//�������� � ������� JPEG
		ms_word = 8,//�������� � ������� Microsoft Word
		ms_excel = 9,//�������� � ������� Microsoft Excel
		odf_text = 10,//�������� � ������� Open Document Text
		odf_spreadsheet = 11,//�������� � ������� Open Document Spreadsheet
		oxml_word = 12,//�������� � ������� Open XML Word
		oxml_spreadsheet = 13,//�������� � ������� Open XML Spreadsheet
		����������� = 14,
	}
	public static partial class ���������������������_��������//:������������������
	{
		public static readonly Guid �����866 = new Guid("34427ea5-e702-a335-46be-42b098da877b");//����� � ��������� DOS
		public static readonly Guid �����1251 = new Guid("15844b98-f49a-3116-4fa1-8f4d87c2b717");
		public static readonly Guid xml = new Guid("7145d88b-73a2-74e7-488e-5314cad2ab82");
		public static readonly Guid html = new Guid("f6be9991-c775-bc8f-4105-5a32d46d1d6c");
		public static readonly Guid pdf = new Guid("153e2f98-22d7-451c-46af-de9cdea310f5");//�������� � ������� PDF
		public static readonly Guid rtf = new Guid("8b6c2fa9-2a14-ed2d-4d7c-f2ecc0e6083c");//�������� � ������� RTF
		public static readonly Guid tiff = new Guid("831a17a5-cd5b-0f2d-440a-809ad8e33a14");//�������� � ������� TIFF
		public static readonly Guid jpeg = new Guid("77cfa59c-19a3-fcca-4b59-f46436701a44");//�������� � ������� JPEG
		public static readonly Guid ms_word = new Guid("0bee1da5-6915-709d-4fb5-48312c240515");//�������� � ������� Microsoft Word
		public static readonly Guid ms_excel = new Guid("6c406c84-8efa-faba-47cd-bb8477fce2ae");//�������� � ������� Microsoft Excel
		public static readonly Guid odf_text = new Guid("3ba82395-a794-48cd-4f99-c6bd8ffe72ec");//�������� � ������� Open Document Text
		public static readonly Guid odf_spreadsheet = new Guid("681867b0-e6ae-7ad2-45b4-c95f37943491");//�������� � ������� Open Document Spreadsheet
		public static readonly Guid oxml_word = new Guid("24ce678c-5ba1-3e81-45cf-b1c4332da8bc");//�������� � ������� Open XML Word
		public static readonly Guid oxml_spreadsheet = new Guid("cd412ab6-dd37-be6e-4121-4ce7b5cdb6f9");//�������� � ������� Open XML Spreadsheet
		public static readonly Guid ����������� = new Guid("9edcf298-72c5-1003-4d7d-00e8acf5175c");
		public static ��������������������� ��������(this ��������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������� ��������(this ��������������������� ��������, Guid ������)
		{
			if(������ == �����866)
			{
				return ���������������������.�����866;
			}
			else if(������ == �����1251)
			{
				return ���������������������.�����1251;
			}
			else if(������ == xml)
			{
				return ���������������������.xml;
			}
			else if(������ == html)
			{
				return ���������������������.html;
			}
			else if(������ == pdf)
			{
				return ���������������������.pdf;
			}
			else if(������ == rtf)
			{
				return ���������������������.rtf;
			}
			else if(������ == tiff)
			{
				return ���������������������.tiff;
			}
			else if(������ == jpeg)
			{
				return ���������������������.jpeg;
			}
			else if(������ == ms_word)
			{
				return ���������������������.ms_word;
			}
			else if(������ == ms_excel)
			{
				return ���������������������.ms_excel;
			}
			else if(������ == odf_text)
			{
				return ���������������������.odf_text;
			}
			else if(������ == odf_spreadsheet)
			{
				return ���������������������.odf_spreadsheet;
			}
			else if(������ == oxml_word)
			{
				return ���������������������.oxml_word;
			}
			else if(������ == oxml_spreadsheet)
			{
				return ���������������������.oxml_spreadsheet;
			}
			else if(������ == �����������)
			{
				return ���������������������.�����������;
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
				case ���������������������.�����866: return �����866;
				case ���������������������.�����1251: return �����1251;
				case ���������������������.xml: return xml;
				case ���������������������.html: return html;
				case ���������������������.pdf: return pdf;
				case ���������������������.rtf: return rtf;
				case ���������������������.tiff: return tiff;
				case ���������������������.jpeg: return jpeg;
				case ���������������������.ms_word: return ms_word;
				case ���������������������.ms_excel: return ms_excel;
				case ���������������������.odf_text: return odf_text;
				case ���������������������.odf_spreadsheet: return odf_spreadsheet;
				case ���������������������.oxml_word: return oxml_word;
				case ���������������������.oxml_spreadsheet: return oxml_spreadsheet;
				case ���������������������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
