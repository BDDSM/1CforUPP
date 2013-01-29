
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiRaschetaSebestoimosti")]
	[Route("/Catalogs/NastrojjkiRaschetaSebestoimosti/{Code}")]
	public class NastrojjkiRaschetaSebestoimostiRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<NastrojjkiRaschetaSebestoimostiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiRaschetaSebestoimostiResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiRaschetaSebestoimostis")]
	[Route("/Catalogs/NastrojjkiRaschetaSebestoimostis/{Codes}")]
	public class NastrojjkiRaschetaSebestoimostisRequest/*�����������������������������������*/: IReturn<List<NastrojjkiRaschetaSebestoimostiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiRaschetaSebestoimostisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiRaschetaSebestoimostisResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiRaschetaSebestoimostiService /*�����������������������������������*/ : Service
	{
		public object Any(NastrojjkiRaschetaSebestoimostiRequest request)
		{
			return new NastrojjkiRaschetaSebestoimostiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiRaschetaSebestoimostiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiRaschetaSebestoimostiResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiRaschetaSebestoimostisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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
