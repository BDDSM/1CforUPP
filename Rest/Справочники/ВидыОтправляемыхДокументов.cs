
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyOtpravlyaemykhDokumentov")]
	[Route("/Catalogs/VidyOtpravlyaemykhDokumentov/{Code}")]
	public class VidyOtpravlyaemykhDokumentovRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<VidyOtpravlyaemykhDokumentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyOtpravlyaemykhDokumentovResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyOtpravlyaemykhDokumentovs")]
	[Route("/Catalogs/VidyOtpravlyaemykhDokumentovs/{Codes}")]
	public class VidyOtpravlyaemykhDokumentovsRequest/*��������������������������������*/: IReturn<List<VidyOtpravlyaemykhDokumentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyOtpravlyaemykhDokumentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyOtpravlyaemykhDokumentovsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyOtpravlyaemykhDokumentovService /*��������������������������������*/ : Service
	{
		public object Any(VidyOtpravlyaemykhDokumentovRequest request)
		{
			return new VidyOtpravlyaemykhDokumentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyOtpravlyaemykhDokumentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyOtpravlyaemykhDokumentovResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(VidyOtpravlyaemykhDokumentovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
