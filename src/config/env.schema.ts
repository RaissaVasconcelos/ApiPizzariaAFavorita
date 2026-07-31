import * as z from 'zod';

export const envSchema = z.object({
  NODE_ENV: z.enum(['development', 'text', 'production']),
  PORT: z.coerce.number().default(3000),
  DATABASE_URL: z.string().min(1),
  JWT_SECRET: z.string().min(1),
  JWT_EXPIRES_IN: z.string().default('id'),
});

export type Env = z.infer<typeof envSchema>;
