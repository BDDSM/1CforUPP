
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyEzhegodnykhOtpuskov")]
	[Route("/Catalogs/VidyEzhegodnykhOtpuskov/{Code}")]
	public class VidyEzhegodnykhOtpuskovRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<VidyEzhegodnykhOtpuskovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyEzhegodnykhOtpuskovResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyEzhegodnykhOtpuskovs")]
	[Route("/Catalogs/VidyEzhegodnykhOtpuskovs/{Codes}")]
	public class VidyEzhegodnykhOtpuskovsRequest/*���������������������������*/: IReturn<List<VidyEzhegodnykhOtpuskovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyEzhegodnykhOtpuskovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyEzhegodnykhOtpuskovsResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class VidyEzhegodnykhOtpuskovService /*���������������������������*/ : Service
	{
		public object Any(VidyEzhegodnykhOtpuskovRequest request)
		{
			return new VidyEzhegodnykhOtpuskovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyEzhegodnykhOtpuskovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyEzhegodnykhOtpuskovResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(VidyEzhegodnykhOtpuskovsRequest request)
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
