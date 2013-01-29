
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SostavOcenochnykhSHkalKompetencijj")]
	[Route("/Catalogs/SostavOcenochnykhSHkalKompetencijj/{Code}")]
	public class SostavOcenochnykhSHkalKompetencijjRequest/*������������������������������������*/: V82.�����������������.������������������������������,IReturn<SostavOcenochnykhSHkalKompetencijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SostavOcenochnykhSHkalKompetencijjResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SostavOcenochnykhSHkalKompetencijjs")]
	[Route("/Catalogs/SostavOcenochnykhSHkalKompetencijjs/{Codes}")]
	public class SostavOcenochnykhSHkalKompetencijjsRequest/*������������������������������������*/: IReturn<List<SostavOcenochnykhSHkalKompetencijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SostavOcenochnykhSHkalKompetencijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SostavOcenochnykhSHkalKompetencijjsResponse//�����������������������������������
	{
		public string Result {get;set;}
	}


	public class SostavOcenochnykhSHkalKompetencijjService /*������������������������������������*/ : Service
	{
		public object Any(SostavOcenochnykhSHkalKompetencijjRequest request)
		{
			return new SostavOcenochnykhSHkalKompetencijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SostavOcenochnykhSHkalKompetencijjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������.�����������(���������);
				if (������ == null)
				{
					return new SostavOcenochnykhSHkalKompetencijjResponse() {Result = "������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������.�����������(1);
			}
		}

		public object Get(SostavOcenochnykhSHkalKompetencijjsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������.�����������(���������);
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
