
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TorgovoeOborudovanie")]
	[Route("/Catalogs/TorgovoeOborudovanie/{Code}")]
	public class TorgovoeOborudovanieRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<TorgovoeOborudovanieRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TorgovoeOborudovanieResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TorgovoeOborudovanies")]
	[Route("/Catalogs/TorgovoeOborudovanies/{Codes}")]
	public class TorgovoeOborudovaniesRequest/*��������������������������*/: IReturn<List<TorgovoeOborudovanieRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TorgovoeOborudovaniesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TorgovoeOborudovaniesResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class TorgovoeOborudovanieService /*��������������������������*/ : Service
	{
		public object Any(TorgovoeOborudovanieRequest request)
		{
			return new TorgovoeOborudovanieResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TorgovoeOborudovanieRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new TorgovoeOborudovanieResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(TorgovoeOborudovaniesRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
