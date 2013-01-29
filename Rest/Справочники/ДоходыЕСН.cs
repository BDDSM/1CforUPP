
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokhodyESN")]
	[Route("/Catalogs/DokhodyESN/{Code}")]
	public class DokhodyESNRequest/*���������������*/: V82.�����������������.���������,IReturn<DokhodyESNRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokhodyESNResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokhodyESNs")]
	[Route("/Catalogs/DokhodyESNs/{Codes}")]
	public class DokhodyESNsRequest/*���������������*/: IReturn<List<DokhodyESNRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokhodyESNsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokhodyESNsResponse//��������������
	{
		public string Result {get;set;}
	}


	public class DokhodyESNService /*���������������*/ : Service
	{
		public object Any(DokhodyESNRequest request)
		{
			return new DokhodyESNResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokhodyESNRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new DokhodyESNResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(DokhodyESNsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������.�����������(���������);
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
