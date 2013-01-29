
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Proekty")]
	[Route("/Catalogs/Proekty/{Code}")]
	public class ProektyRequest/*�������������*/: V82.�����������������.�������,IReturn<ProektyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProektyResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Proektys")]
	[Route("/Catalogs/Proektys/{Codes}")]
	public class ProektysRequest/*�������������*/: IReturn<List<ProektyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProektysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProektysResponse//������������
	{
		public string Result {get;set;}
	}


	public class ProektyService /*�������������*/ : Service
	{
		public object Any(ProektyRequest request)
		{
			return new ProektyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProektyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new ProektyResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(ProektysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������.�����������(���������);
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
