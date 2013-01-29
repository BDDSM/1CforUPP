
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DogovoryEHkvajjringa")]
	[Route("/Catalogs/DogovoryEHkvajjringa/{Code}")]
	public class DogovoryEHkvajjringaRequest/*������������������������*/: V82.�����������������.������������������,IReturn<DogovoryEHkvajjringaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DogovoryEHkvajjringaResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DogovoryEHkvajjringas")]
	[Route("/Catalogs/DogovoryEHkvajjringas/{Codes}")]
	public class DogovoryEHkvajjringasRequest/*������������������������*/: IReturn<List<DogovoryEHkvajjringaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DogovoryEHkvajjringasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DogovoryEHkvajjringasResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class DogovoryEHkvajjringaService /*������������������������*/ : Service
	{
		public object Any(DogovoryEHkvajjringaRequest request)
		{
			return new DogovoryEHkvajjringaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DogovoryEHkvajjringaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new DogovoryEHkvajjringaResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(DogovoryEHkvajjringasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
