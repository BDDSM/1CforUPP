
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UchenyeStepeni")]
	[Route("/Catalogs/UchenyeStepeni/{Code}")]
	public class UchenyeStepeniRequest/*�������������������*/: V82.�����������������.�������������,IReturn<UchenyeStepeniRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UchenyeStepeniResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UchenyeStepenis")]
	[Route("/Catalogs/UchenyeStepenis/{Codes}")]
	public class UchenyeStepenisRequest/*�������������������*/: IReturn<List<UchenyeStepeniRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UchenyeStepenisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UchenyeStepenisResponse//������������������
	{
		public string Result {get;set;}
	}


	public class UchenyeStepeniService /*�������������������*/ : Service
	{
		public object Any(UchenyeStepeniRequest request)
		{
			return new UchenyeStepeniResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UchenyeStepeniRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new UchenyeStepeniResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(UchenyeStepenisRequest request)
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
