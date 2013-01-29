
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokhodyNDFL")]
	[Route("/Catalogs/DokhodyNDFL/{Code}")]
	public class DokhodyNDFLRequest/*����������������*/: V82.�����������������.����������,IReturn<DokhodyNDFLRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokhodyNDFLResponse//���������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokhodyNDFLs")]
	[Route("/Catalogs/DokhodyNDFLs/{Codes}")]
	public class DokhodyNDFLsRequest/*����������������*/: IReturn<List<DokhodyNDFLRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokhodyNDFLsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokhodyNDFLsResponse//���������������
	{
		public string Result {get;set;}
	}


	public class DokhodyNDFLService /*����������������*/ : Service
	{
		public object Any(DokhodyNDFLRequest request)
		{
			return new DokhodyNDFLResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokhodyNDFLRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������.�����������(���������);
				if (������ == null)
				{
					return new DokhodyNDFLResponse() {Result = "���������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������.�����������(1);
			}
		}

		public object Get(DokhodyNDFLsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������.�����������(���������);
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
