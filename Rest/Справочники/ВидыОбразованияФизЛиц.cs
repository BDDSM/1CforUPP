
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyObrazovaniyaFizLic")]
	[Route("/Catalogs/VidyObrazovaniyaFizLic/{Code}")]
	public class VidyObrazovaniyaFizLicRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<VidyObrazovaniyaFizLicRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyObrazovaniyaFizLicResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyObrazovaniyaFizLics")]
	[Route("/Catalogs/VidyObrazovaniyaFizLics/{Codes}")]
	public class VidyObrazovaniyaFizLicsRequest/*���������������������������*/: IReturn<List<VidyObrazovaniyaFizLicRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyObrazovaniyaFizLicsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyObrazovaniyaFizLicsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class VidyObrazovaniyaFizLicService /*���������������������������*/ : Service
	{
		public object Any(VidyObrazovaniyaFizLicRequest request)
		{
			return new VidyObrazovaniyaFizLicResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyObrazovaniyaFizLicRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyObrazovaniyaFizLicResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(VidyObrazovaniyaFizLicsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
