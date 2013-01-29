
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyVzaimoraschetov")]
	[Route("/Catalogs/VidyVzaimoraschetov/{Code}")]
	public class VidyVzaimoraschetovRequest/*������������������������*/: V82.�����������������.������������������,IReturn<VidyVzaimoraschetovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyVzaimoraschetovResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyVzaimoraschetovs")]
	[Route("/Catalogs/VidyVzaimoraschetovs/{Codes}")]
	public class VidyVzaimoraschetovsRequest/*������������������������*/: IReturn<List<VidyVzaimoraschetovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyVzaimoraschetovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyVzaimoraschetovsResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class VidyVzaimoraschetovService /*������������������������*/ : Service
	{
		public object Any(VidyVzaimoraschetovRequest request)
		{
			return new VidyVzaimoraschetovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyVzaimoraschetovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyVzaimoraschetovResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(VidyVzaimoraschetovsRequest request)
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
