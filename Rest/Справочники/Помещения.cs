
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Pomeshheniya")]
	[Route("/Catalogs/Pomeshheniya/{Code}")]
	public class PomeshheniyaRequest/*���������������*/: V82.�����������������.���������,IReturn<PomeshheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PomeshheniyaResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Pomeshheniyas")]
	[Route("/Catalogs/Pomeshheniyas/{Codes}")]
	public class PomeshheniyasRequest/*���������������*/: IReturn<List<PomeshheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PomeshheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PomeshheniyasResponse//��������������
	{
		public string Result {get;set;}
	}


	public class PomeshheniyaService /*���������������*/ : Service
	{
		public object Any(PomeshheniyaRequest request)
		{
			return new PomeshheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PomeshheniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new PomeshheniyaResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(PomeshheniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������.�����������(���������);
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
