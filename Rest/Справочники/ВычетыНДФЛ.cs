
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VychetyNDFL")]
	[Route("/Catalogs/VychetyNDFL/{Code}")]
	public class VychetyNDFLRequest/*����������������*/: V82.�����������������.����������,IReturn<VychetyNDFLRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VychetyNDFLResponse//���������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VychetyNDFLs")]
	[Route("/Catalogs/VychetyNDFLs/{Codes}")]
	public class VychetyNDFLsRequest/*����������������*/: IReturn<List<VychetyNDFLRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VychetyNDFLsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VychetyNDFLsResponse//���������������
	{
		public string Result {get;set;}
	}


	public class VychetyNDFLService /*����������������*/ : Service
	{
		public object Any(VychetyNDFLRequest request)
		{
			return new VychetyNDFLResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VychetyNDFLRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������.�����������(���������);
				if (������ == null)
				{
					return new VychetyNDFLResponse() {Result = "���������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������.�����������(1);
			}
		}

		public object Get(VychetyNDFLsRequest request)
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
