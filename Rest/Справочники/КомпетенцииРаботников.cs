
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KompetenciiRabotnikov")]
	[Route("/Catalogs/KompetenciiRabotnikov/{Code}")]
	public class KompetenciiRabotnikovRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<KompetenciiRabotnikovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KompetenciiRabotnikovResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KompetenciiRabotnikovs")]
	[Route("/Catalogs/KompetenciiRabotnikovs/{Codes}")]
	public class KompetenciiRabotnikovsRequest/*���������������������������*/: IReturn<List<KompetenciiRabotnikovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KompetenciiRabotnikovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KompetenciiRabotnikovsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class KompetenciiRabotnikovService /*���������������������������*/ : Service
	{
		public object Any(KompetenciiRabotnikovRequest request)
		{
			return new KompetenciiRabotnikovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KompetenciiRabotnikovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new KompetenciiRabotnikovResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(KompetenciiRabotnikovsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
