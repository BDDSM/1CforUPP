
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/BlankiStrogojjOtchetnosti")]
	[Route("/Catalogs/BlankiStrogojjOtchetnosti/{Code}")]
	public class BlankiStrogojjOtchetnostiRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<BlankiStrogojjOtchetnostiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class BlankiStrogojjOtchetnostiResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/BlankiStrogojjOtchetnostis")]
	[Route("/Catalogs/BlankiStrogojjOtchetnostis/{Codes}")]
	public class BlankiStrogojjOtchetnostisRequest/*�����������������������������*/: IReturn<List<BlankiStrogojjOtchetnostiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public BlankiStrogojjOtchetnostisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class BlankiStrogojjOtchetnostisResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class BlankiStrogojjOtchetnostiService /*�����������������������������*/ : Service
	{
		public object Any(BlankiStrogojjOtchetnostiRequest request)
		{
			return new BlankiStrogojjOtchetnostiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(BlankiStrogojjOtchetnostiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new BlankiStrogojjOtchetnostiResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(BlankiStrogojjOtchetnostisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
