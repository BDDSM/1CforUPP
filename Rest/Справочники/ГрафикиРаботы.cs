
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GrafikiRaboty")]
	[Route("/Catalogs/GrafikiRaboty/{Code}")]
	public class GrafikiRabotyRequest/*�������������������*/: V82.�����������������.�������������,IReturn<GrafikiRabotyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GrafikiRabotyResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GrafikiRabotys")]
	[Route("/Catalogs/GrafikiRabotys/{Codes}")]
	public class GrafikiRabotysRequest/*�������������������*/: IReturn<List<GrafikiRabotyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GrafikiRabotysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GrafikiRabotysResponse//������������������
	{
		public string Result {get;set;}
	}


	public class GrafikiRabotyService /*�������������������*/ : Service
	{
		public object Any(GrafikiRabotyRequest request)
		{
			return new GrafikiRabotyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GrafikiRabotyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new GrafikiRabotyResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(GrafikiRabotysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
