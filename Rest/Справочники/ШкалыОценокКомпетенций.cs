
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SHkalyOcenokKompetencijj")]
	[Route("/Catalogs/SHkalyOcenokKompetencijj/{Code}")]
	public class SHkalyOcenokKompetencijjRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<SHkalyOcenokKompetencijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SHkalyOcenokKompetencijjResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SHkalyOcenokKompetencijjs")]
	[Route("/Catalogs/SHkalyOcenokKompetencijjs/{Codes}")]
	public class SHkalyOcenokKompetencijjsRequest/*����������������������������*/: IReturn<List<SHkalyOcenokKompetencijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SHkalyOcenokKompetencijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SHkalyOcenokKompetencijjsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class SHkalyOcenokKompetencijjService /*����������������������������*/ : Service
	{
		public object Any(SHkalyOcenokKompetencijjRequest request)
		{
			return new SHkalyOcenokKompetencijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SHkalyOcenokKompetencijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new SHkalyOcenokKompetencijjResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(SHkalyOcenokKompetencijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
