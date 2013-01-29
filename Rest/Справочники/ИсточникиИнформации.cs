
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/IstochnikiInformacii")]
	[Route("/Catalogs/IstochnikiInformacii/{Code}")]
	public class IstochnikiInformaciiRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<IstochnikiInformaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class IstochnikiInformaciiResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/IstochnikiInformaciis")]
	[Route("/Catalogs/IstochnikiInformaciis/{Codes}")]
	public class IstochnikiInformaciisRequest/*�������������������������*/: IReturn<List<IstochnikiInformaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public IstochnikiInformaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class IstochnikiInformaciisResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class IstochnikiInformaciiService /*�������������������������*/ : Service
	{
		public object Any(IstochnikiInformaciiRequest request)
		{
			return new IstochnikiInformaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(IstochnikiInformaciiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new IstochnikiInformaciiResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(IstochnikiInformaciisRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
