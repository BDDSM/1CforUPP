
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RoliKontaktnykhLic")]
	[Route("/Catalogs/RoliKontaktnykhLic/{Code}")]
	public class RoliKontaktnykhLicRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<RoliKontaktnykhLicRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RoliKontaktnykhLicResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RoliKontaktnykhLics")]
	[Route("/Catalogs/RoliKontaktnykhLics/{Codes}")]
	public class RoliKontaktnykhLicsRequest/*�����������������������*/: IReturn<List<RoliKontaktnykhLicRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RoliKontaktnykhLicsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RoliKontaktnykhLicsResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class RoliKontaktnykhLicService /*�����������������������*/ : Service
	{
		public object Any(RoliKontaktnykhLicRequest request)
		{
			return new RoliKontaktnykhLicResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RoliKontaktnykhLicRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new RoliKontaktnykhLicResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(RoliKontaktnykhLicsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
