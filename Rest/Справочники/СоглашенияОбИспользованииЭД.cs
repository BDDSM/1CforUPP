
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SoglasheniyaObIspolzovaniiEHD")]
	[Route("/Catalogs/SoglasheniyaObIspolzovaniiEHD/{Code}")]
	public class SoglasheniyaObIspolzovaniiEHDRequest/*���������������������������������*/: V82.�����������������.���������������������������,IReturn<SoglasheniyaObIspolzovaniiEHDRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SoglasheniyaObIspolzovaniiEHDResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SoglasheniyaObIspolzovaniiEHDs")]
	[Route("/Catalogs/SoglasheniyaObIspolzovaniiEHDs/{Codes}")]
	public class SoglasheniyaObIspolzovaniiEHDsRequest/*���������������������������������*/: IReturn<List<SoglasheniyaObIspolzovaniiEHDRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SoglasheniyaObIspolzovaniiEHDsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SoglasheniyaObIspolzovaniiEHDsResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	public class SoglasheniyaObIspolzovaniiEHDService /*���������������������������������*/ : Service
	{
		public object Any(SoglasheniyaObIspolzovaniiEHDRequest request)
		{
			return new SoglasheniyaObIspolzovaniiEHDResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SoglasheniyaObIspolzovaniiEHDRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������.�����������(���������);
				if (������ == null)
				{
					return new SoglasheniyaObIspolzovaniiEHDResponse() {Result = "��������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������.�����������(1);
			}
		}

		public object Get(SoglasheniyaObIspolzovaniiEHDsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������.�����������(���������);
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
