
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Smeny")]
	[Route("/Catalogs/Smeny/{Code}")]
	public class SmenyRequest/*�����������*/: V82.�����������������.�����,IReturn<SmenyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SmenyResponse//����������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Smenys")]
	[Route("/Catalogs/Smenys/{Codes}")]
	public class SmenysRequest/*�����������*/: IReturn<List<SmenyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SmenysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SmenysResponse//����������
	{
		public string Result {get;set;}
	}


	public class SmenyService /*�����������*/ : Service
	{
		public object Any(SmenyRequest request)
		{
			return new SmenyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SmenyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����.�����������(���������);
				if (������ == null)
				{
					return new SmenyResponse() {Result = "����� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����.�����������(1);
			}
		}

		public object Get(SmenysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����.�����������(���������);
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
