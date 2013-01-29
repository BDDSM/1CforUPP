
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyKontaktnojjInformacii")]
	[Route("/Catalogs/VidyKontaktnojjInformacii/{Code}")]
	public class VidyKontaktnojjInformaciiRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<VidyKontaktnojjInformaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyKontaktnojjInformaciiResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyKontaktnojjInformaciis")]
	[Route("/Catalogs/VidyKontaktnojjInformaciis/{Codes}")]
	public class VidyKontaktnojjInformaciisRequest/*������������������������������*/: IReturn<List<VidyKontaktnojjInformaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyKontaktnojjInformaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyKontaktnojjInformaciisResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class VidyKontaktnojjInformaciiService /*������������������������������*/ : Service
	{
		public object Any(VidyKontaktnojjInformaciiRequest request)
		{
			return new VidyKontaktnojjInformaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyKontaktnojjInformaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyKontaktnojjInformaciiResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(VidyKontaktnojjInformaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
