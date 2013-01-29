
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TSDFormatyDannykh")]
	[Route("/Catalogs/TSDFormatyDannykh/{Code}")]
	public class TSDFormatyDannykhRequest/*����������������������*/: V82.�����������������.����������������,IReturn<TSDFormatyDannykhRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TSDFormatyDannykhResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TSDFormatyDannykhs")]
	[Route("/Catalogs/TSDFormatyDannykhs/{Codes}")]
	public class TSDFormatyDannykhsRequest/*����������������������*/: IReturn<List<TSDFormatyDannykhRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TSDFormatyDannykhsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TSDFormatyDannykhsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class TSDFormatyDannykhService /*����������������������*/ : Service
	{
		public object Any(TSDFormatyDannykhRequest request)
		{
			return new TSDFormatyDannykhResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TSDFormatyDannykhRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new TSDFormatyDannykhResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(TSDFormatyDannykhsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
