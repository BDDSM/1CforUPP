
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KlassifikatorStranMira")]
	[Route("/Catalogs/KlassifikatorStranMira/{Code}")]
	public class KlassifikatorStranMiraRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<KlassifikatorStranMiraRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KlassifikatorStranMiraResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KlassifikatorStranMiras")]
	[Route("/Catalogs/KlassifikatorStranMiras/{Codes}")]
	public class KlassifikatorStranMirasRequest/*����������������������������*/: IReturn<List<KlassifikatorStranMiraRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KlassifikatorStranMirasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KlassifikatorStranMirasResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class KlassifikatorStranMiraService /*����������������������������*/ : Service
	{
		public object Any(KlassifikatorStranMiraRequest request)
		{
			return new KlassifikatorStranMiraResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KlassifikatorStranMiraRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new KlassifikatorStranMiraResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(KlassifikatorStranMirasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
